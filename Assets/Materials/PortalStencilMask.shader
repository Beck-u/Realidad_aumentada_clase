Shader "Custom/PortalStencilMask"
{
    Properties
    {
        [MainColor] _BaseColor("Base Color", Color) = (1, 1, 1, 1)
        [MainTexture] _BaseMap("Base Map", 2D) = "white" {}
    }

    SubShader
    {
        Tags 
        { 
            "RenderType" = "Opaque"
            "Queue" = "Geometry-1" 
        }

        Pass
        {
            ColorMask 0
            ZWrite Off
            ZTest LEqual

            Stencil
            {
                Ref 1
                Comp Always
                Pass Replace
            }
        }
    }
}
