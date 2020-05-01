//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace PixelSmith.Effects{
	
	/// <summary>An effect that applies cartoon-like shading (posterization).</summary>
	public class ToonShaderEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(ToonShaderEffect), 0);
		public static readonly DependencyProperty LevelsProperty = DependencyProperty.Register("Levels", typeof(double), typeof(ToonShaderEffect), new UIPropertyMetadata(((double)(5D)), PixelShaderConstantCallback(0)));
		public ToonShaderEffect() {
			PixelShader pixelShader = new PixelShader();
			pixelShader.UriSource = new Uri("/WpfControls;component/Effects/ToonShaderEffect.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(LevelsProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The number of color levels to use.</summary>
		public double Levels {
			get {
				return ((double)(this.GetValue(LevelsProperty)));
			}
			set {
				this.SetValue(LevelsProperty, value);
			}
		}
	}
}
