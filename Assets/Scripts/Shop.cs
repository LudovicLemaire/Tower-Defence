﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {
    public TowerBlueprint basicTower;
    public TowerBlueprint siegeTower;
    BuildManager buildManager;
    
    void Start () {
        buildManager = BuildManager.instance;
    }
    public void SelectBasicTower () {
        buildManager.SelectTowerToBuild(basicTower);
    }
    public void SelectSiegeTower () {
        buildManager.SelectTowerToBuild(siegeTower);
    }
}
