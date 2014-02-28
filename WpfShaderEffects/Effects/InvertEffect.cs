﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace WpfShaderEffects {

    /// <summary>
    /// A shader effect that inverts the colors of a target texture
    /// </summary>
    public class InvertEffect : ShaderEffect {

        #region Dependency Properties

        public static readonly DependencyProperty InputProperty =
            ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(InvertEffect), 0);

        /// <summary>
        /// Brush that acts as the input
        /// </summary>
        public Brush Input {
            get {
                return (Brush)GetValue(InputProperty);
            }
            set {
                SetValue(InputProperty, value);
            }
        }

        #endregion

        public InvertEffect() {
            PixelShader = new PixelShader {
                UriSource = Global.MakePackUri("Shaders/Invert.ps")
            };
            UpdateShaderValue(InputProperty);
        }

    }

}
