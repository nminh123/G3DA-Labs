using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] LayerMask layerMask1;
    [SerializeField] LayerMask layerMask2;

    int touch1, touch2;
    // Update is called once per frame
    void Update()
    {
        InitRaycast();
    }

    void InitRaycast()
    {
        if (Physics.Raycast(this.transform.position, transform.forward, out var hit, 20f, layerMask1))
        {
            Debug.DrawRay(this.transform.position, transform.forward * hit.distance, Color.blue);
            touch1 += 1;
            Debug.Log(touch1);
        }
        else if (Physics.Raycast(this.transform.position, transform.forward, out var hit2, 20f, layerMask2))
        {
            Debug.DrawRay(this.transform.position, transform.forward * hit2.distance, Color.green);
            touch2 += 1;
            Debug.Log(touch2);
        }
        else
        {
            Debug.DrawRay(this.transform.position, transform.forward * 15, Color.yellow);
        }
    }

    public int getTouch1()
    {
        return touch1;
    }

    public int getTouch2()
    {
        return touch2;
    }
}
