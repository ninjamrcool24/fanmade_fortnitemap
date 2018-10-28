using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_night : MonoBehaviour
{

    public Material day;
    public Material night;

    void Start()
    {
        RenderSettings.skybox = day;
    }
    void Update()
    {
        Debug.Log("rotation x" + transform.rotation.eulerAngles.x);

        transform.Rotate(new Vector3(-3 * Time.deltaTime, 0, 0), Space.World);
        if (transform.rotation.eulerAngles.x > 284.813)
        {
            RenderSettings.skybox = night;
            Debug.Log("night");
            gameObject.SetActive(false);
        }
        else{
            RenderSettings.skybox = day;
            Debug.Log("day");
            gameObject.SetActive(true);
        }
    }
}
