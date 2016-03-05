using UnityEngine;
using System.Collections;
using System;

public interface IEquipmentManager {

    BaseEquipment GetEquipmentByID(int id);
    BaseEquipment GetEquipmentByName();
    BaseEquipment[] GetAllEquipment();
    string[] GetAllEquipmentName();
    int[] GetAllEquipmentId();

}
