using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class HyperposStaticReferences : MonoBehaviour {

	public static float OctantSize { get; private set; }
    [SerializeField]
    private float octantSize;

    public static Camera MainCamera { get; private set; }
    [SerializeField]
    private Camera mainCamera;



    private void OnValidate()
    {
        MainCamera = mainCamera;
    }

    private void Awake()
    {
        OctantSize = octantSize;
        MainCamera = mainCamera;
    }

    private void Start()
    {
        World.Active.GetOrCreateManager<HPMeshInstanceRendererSystem>().ActiveCamera = mainCamera;
    }
}
