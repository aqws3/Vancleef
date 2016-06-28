﻿using UnityEngine;
using System.Collections.Generic;

public class BaseEnemyLevel : ScriptableObject
{
    public float vida;
    public float velocidad;
    public Sprite sprite;
    public int puntaje;
    public float shootingFreq;
    public float bulletSpeed;
    public List<Vector3> bulletSpawnPoints;
}
