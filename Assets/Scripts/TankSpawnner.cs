using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    [SerializeField] private GameObject _tankPerfab;
    void Start()
    {
        Instantiate(_tankPerfab , Vector3.zero, Quaternion.identity );
    }
}
