using UnityEngine;

public class LightCtrl : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] float intensitySpeed;
    [SerializeField] bool isEqual = true;
    float min = 1, max = 5;

    void Update()
    {
        Day();
    }

    void Day()
    {
        if(light == null) return;

        if(isEqual)
        {
            light.intensity += Time.deltaTime + intensitySpeed;
            if(light.intensity >= max)
                isEqual = false;
        }
        else
        {
            light.intensity -= Time.deltaTime + intensitySpeed;
            if(light.intensity <= min)
                isEqual = true;
        }
    }
}