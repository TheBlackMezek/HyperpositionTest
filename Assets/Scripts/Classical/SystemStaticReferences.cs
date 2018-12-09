using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SystemStaticReferences : MonoBehaviour {

    public static TMPro.TextMeshProUGUI SpeedText { get; private set; }
    [SerializeField]
    private TMPro.TextMeshProUGUI speedText;

    public static GameObject AttachPrefab { get; private set; }
    [SerializeField]
    private GameObject attachPrefab;



    private void Awake()
    {
        SpeedText = speedText;
        AttachPrefab = attachPrefab;
    }

}
