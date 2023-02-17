﻿using UnityEngine;
using UnityEngine.UI;

namespace VertexStudio.Generic {

    public class AdaptiveCompanyHorizontalLogo : MonoBehaviour {

        // Start is called before the first frame update
        private void OnEnable() {
        
            Image image = GetComponent<Image>();

            if( image == null ) { 
            
                Debug.LogError( "Cannot find an image for adaptation!" );

                return;
            }

            else { 
            
                Sprite sprite = ProjectManager.Instance.GetCompanySprite( SpriteType.LogoHorizontalSprite );

                if( sprite != null ) {

                    image.sprite = sprite;
                }
            }
        }
    }
}