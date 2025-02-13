using UnityEngine;

namespace Unity.FantasyKingdom
{
    public class LayerCull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Camera cam = GetComponent<Camera>();
            float[] distances = new float[32];
            distances[10] = 15;
            cam.layerCullDistances = distances;
        }
    }
}
