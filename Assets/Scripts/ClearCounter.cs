using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private Transform tomatoprefab;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Transform tomatoTransform = Instantiate(tomatoprefab, counterTopPoint);
        tomatoTransform.localPosition = Vector3.zero;
    }
}
