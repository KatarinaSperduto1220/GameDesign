using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

     void Awake()
    {
        if(instance != null) 
        {
            Debug.LogError("More than one build manager in scene");
            return;
        }
        instance = this;

    }

    //void Start()
    //{
    //    turretToBuild = standardTurretPrefab; 
    //}

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    //public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost;  } }

    public void BuildTurretOn(Node node)
    {
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

    //public GameObject GetTurretToBuild()
    //{
    //    return turretToBuild; 
    //}

    //public void SetTurretToBuild (GameObject turret)
    //{
    //    turretToBuild = turret;
    //}
}
