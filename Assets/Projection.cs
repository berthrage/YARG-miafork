using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YARG {
    public class Projection : MonoBehaviour {
		public Material material; //this material will contain distortion shader
		

		
		
		private void OnRenderImage(RenderTexture src, RenderTexture dest) {
			Graphics.Blit(src, dest, material);//apply shader to rendered image
		}
		
      
    }
}
