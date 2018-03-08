Shader "Unlit/Toon Water"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
		_EdgeColor ("Edge Color", Color) = (1,1,1,1)
		_DepthFactor ("Depth Factor", float) = 1.0
	}
	SubShader
	{
		Pass
		{
			CGPROGRAM
			#include "UnityCG.cginc"

			#pragma vertex vert
			#pragma fragment frag

			sampler2D _CameraDepthTexture;

			struct vertexInput
			{
				float4 vertex : POSITION;
			};

			struct vertexOutput
			{
				float4 pos : SV_POSITION;
				float4 screenPos : TEXCOORD1;		
			};

			vertexOutput vert (vertexInput input)
			{
				vertexOutput output;

				output.pos = UnityObjectToClipPos(input.vertex);
				output.screenPos = ComputeScreenPos(output.pos);

				return output;
			}

			float4 frag (vertexOutput input) : COLOR
			{
				float4 depthSample = SAMPLE_DEPTH_TEXTURE_PROJ (_CameraDepthTexture, input.screenPos);
				float depth = LinearEyeDepth (depthSample).r;

				float4 foamLine = 1 - saturate (_DepthFactor * (depth - input.screenPos.w));

				float col = _Color + foamLine * _EdgeColor;

				return foamline;
			}
			ENDCG
		}
	}
}