using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] RayCast rc;

    [SerializeField] TMP_Text touch1, touch2;

    void Update()
    {
        touch1.text = rc.getTouch1().ToString();
        touch2.text = rc.getTouch2().ToString();
    }
}