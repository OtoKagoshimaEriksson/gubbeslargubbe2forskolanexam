using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrast : MonoBehaviour
{
    [SerializeField] Material postProcessingMaterial;

    private void Update()
    {
        if (postProcessingMaterial != null)
        {
            float contrast = Mathf.PingPong(Time.deltaTime, 1.0f);
            postProcessingMaterial.SetFloat("_Contrast", contrast);
        }
    }
}
