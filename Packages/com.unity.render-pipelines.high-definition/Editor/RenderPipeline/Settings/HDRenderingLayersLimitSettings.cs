using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace UnityEditor.Rendering.HighDefinition
{
    /// <summary>
    /// Rendering Layers settings class.
    /// </summary>
    [Serializable]
    [HideInInspector]
    [SupportedOnRenderPipeline(typeof(HDRenderPipelineAsset))]
    public class HDRenderingLayersLimitSettings : RenderingLayersLimitSettings
    {
        /// <summary>
        /// Maximum number of the supported Rendering Layers on HDRP.
        /// </summary>
        protected override int maxRenderingLayersForPipeline => 16;
    }
}
