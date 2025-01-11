using System.Collections;
using UnityEngine;

public class ThunderCtrl : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] AudioSource source;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(LightEnable());
        } 
    }

    IEnumerator LightEnable()
    {
        light.enabled = true;
        yield return new WaitForSeconds(.1f);
        light.enabled = false;
        source.Play();
    }
}