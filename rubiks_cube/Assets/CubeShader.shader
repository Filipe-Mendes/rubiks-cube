Shader "Unlit/CubeShader"
{
    Properties
    {
        _Right ("Right", Color) = (1, 0, 0, 1)
        _Left  ("Left", Color) = (0.5, 0, 0, 1)
        _Top   ("Top", Color) = (0, 1, 0, 1)
        _Bottom("Bottom", Color) = (0, 0.5, 0, 1)
        _Front ("Front", Color) = (0, 0, 1, 1)
        _Back  ("Back", Color) = (0, 0, 0.5, 1)
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
                float3 objectNormal : TEXCOORD0;
            };

            float4 _Right, _Left;
            float4 _Top, _Bottom;
            float4 _Front, _Back;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.objectNormal = normalize(v.normal); // Keep normals in object space
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float3 n = i.objectNormal;

                // Select color based on the most dominant normal component
                if (abs(n.x) > abs(n.y) && abs(n.x) > abs(n.z))
                    return n.x > 0 ? _Right : _Left;
                else if (abs(n.y) > abs(n.x) && abs(n.y) > abs(n.z))
                    return n.y > 0 ? _Top : _Bottom;
                else
                    return n.z > 0 ? _Front : _Back;
            }
            ENDCG
        }
    }
}
