using UnityEngine;
using System.Collections;

public class GemTransform : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.TransformPoint(new Vector3(15, 40, 39) * Time.deltaTime);

    }
}