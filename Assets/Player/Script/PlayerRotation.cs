using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        Raying();
    }

    void Raying()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 lookPosition = ray.GetPoint(hit.point.magnitude);
            transform.LookAt(new Vector3(lookPosition.x, transform.position.y, lookPosition.z));
        }
        Debug.DrawRay(start: ray.origin, dir: ray.direction * 100, Color.green);
    }
}
