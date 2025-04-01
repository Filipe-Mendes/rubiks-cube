Shader "Unlit/MultiColorShader"
{
    Properties
    {
        _ColorX ("Right & Left", Color) = (1,0,0,1)
        _ColorY ("Top & Bottom", Color) = (0,1,0,1)
        _ColorZ ("Front & Back", Color) = (0,0,1,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float3 normal : TEXCOORD0;
            };

            float4 _ColorX, _ColorY, _ColorZ;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.normal = normalize(v.normal);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float3 n = abs(i.normal);
                return n.x * _ColorX + n.y * _ColorY + n.z * _ColorZ;
            }
            ENDCG
        }
    }
}
