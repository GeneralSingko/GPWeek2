using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : Jobless
{
    //constructor
    public Support(string name = "Max", float baseHealth = 900, float exp = 100
        , int str = 8, int dex = 16, int vit = 12, int cha = 18, int luck = 17, int mag = 15)
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
