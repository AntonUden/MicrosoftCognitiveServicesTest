using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace MicrosoftCognitiveServicesTest {
	public partial class Form1 : Form {
		private static readonly List<VisualFeatureTypes> features = new List<VisualFeatureTypes>() {
			VisualFeatureTypes.Adult,
			VisualFeatureTypes.Brands,
			VisualFeatureTypes.Categories,
			VisualFeatureTypes.Description,
			VisualFeatureTypes.Tags
		};

		public Form1() {
			InitializeComponent();
		}

		private async Task AnalyzeLocalAsync(string imagePath) {
			tbx_Output.Text = "analysing " + imagePath;
			try {
				ComputerVisionClient computerVision = new ComputerVisionClient(new ApiKeyServiceClientCredentials(tbx_Key.Text), new System.Net.Http.DelegatingHandler[] { });
				computerVision.Endpoint = tbx_Endpoint.Text;

				if (!File.Exists(imagePath)) {
					tbx_Output.Text = "Unable to open or read localImagePath: " + imagePath;
					return;
				}

				using (Stream imageStream = File.OpenRead(imagePath)) {
					ImageAnalysis analysis = await computerVision.AnalyzeImageInStreamAsync(imageStream, features);
					String result = "Request ID: " + analysis.RequestId + Environment.NewLine;
					result += "Size: " + analysis.Metadata.Width + "x" + analysis.Metadata.Height + Environment.NewLine;
					result += "Adult score: " + analysis.Adult.AdultScore + " " + analysis.Adult.IsAdultContent.ToString() + Environment.NewLine;
					
					if (analysis.Categories != null) {
						result += Environment.NewLine + "----- Categories -----" + Environment.NewLine;
						foreach (Category c in analysis.Categories) {
							result += Environment.NewLine + c.Name + " | Confidence: " + c.Score + Environment.NewLine;
						}
					}


					if (analysis.Description.Captions != null) {
						result += Environment.NewLine + "----- Captions -----" + Environment.NewLine;
						foreach (ImageCaption c in analysis.Description.Captions) {
							result += Environment.NewLine + c.Text + " | Confidence: " + c.Confidence + Environment.NewLine;
						}
					}

					if (analysis.Tags != null) {
						result += Environment.NewLine + "----- Tags -----" + Environment.NewLine;
						foreach (ImageTag tag in analysis.Tags) {
							result += tag.Name + " | Confidence: " + tag.Confidence + Environment.NewLine;
						}
					}

					if (analysis.Brands != null) {
						result += Environment.NewLine + "----- Brands -----" + Environment.NewLine;
						foreach (DetectedBrand brand in analysis.Brands) {
							result += brand.Name + " | Confidence: " + brand.Confidence + Environment.NewLine;
						}
					}

					tbx_Output.Text = result;
				}
				computerVision.Dispose();
			} catch(Exception e) {
				tbx_Output.Text = e.ToString();
			}
		}

		private void Btn_SelectPath_Click(object sender, EventArgs e) {
			fd_Path.ShowDialog();
		}

		private void Fd_Path_FileOk(object sender, CancelEventArgs e) {
			tbx_Path.Text = fd_Path.FileName;
		}

		private void Btn_Scan_Click(object sender, EventArgs e) {
			if(tbx_Path.Text.Length == 0) {
				return;
			}

			var t1 = AnalyzeLocalAsync(tbx_Path.Text);
			Task.WhenAll(t1).Wait(10);
		}
	}
}
