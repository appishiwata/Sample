Shader "Custom/TransparentMaskedShader"
{
    Properties
    {
        _MainTex ("Main Texture", 2D) = "white" {}
        _MaskTex ("Mask Texture", 2D) = "white" {}
    }
 
    SubShader
    {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        LOD 200
 
        CGPROGRAM
        #pragma surface surf Lambert alpha
 
        sampler2D _MainTex;
        sampler2D _MaskTex;
 
        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MaskTex;
        };
 
        void surf (Input IN, inout SurfaceOutput o)
        {
            half4 mainColor = tex2D(_MainTex, IN.uv_MainTex);
            half maskValue = tex2D(_MaskTex, IN.uv_MaskTex).r;

            o.Albedo = mainColor.rgb;
            o.Alpha = mainColor.a * maskValue; // マスクの値に基づいてアルファ値を設定
        }
        ENDCG
    }
    FallBack "Diffuse"
}
