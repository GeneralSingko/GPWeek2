using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Jobless
{
    //constructor
    public Tank(string name = "Max", float baseHealth = 1000, float exp = 5000
        , int str = 18, int dex = 8, int vit = 20, int cha = 8, int luck = 15, int mag = 8)
    {
        _name = name;
        _baseHealth = baseHealth;
        _exp = exp;
        _str = str;
        _dex = dex;
        _vit = vit;
        _cha = cha;
        _luck = luck;
        _mag = mag;
    }
    public new string GetProperties()
    {
        var properties =
            $"{nameof(_name)}:{_name}, {nameof(_baseHealth)}:{_baseHealth}, {nameof(_exp)}:{_exp}, {nameof(_str)}:{_str}, {nameof(_dex)}:{_dex}, {nameof(_vit)}:{_vit}, {nameof(_cha)}:{_cha}, {nameof(_luck)}:{_luck}, {nameof(_mag)}:{_mag}";

        return properties;
    }
}
