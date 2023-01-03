using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Jobless
{
    //secondary stats
    protected string _name;
    protected float _baseHealth;
    protected float _exp;
    //primary stats
    protected int _str;
    protected int _dex;
    protected int _vit;
    protected int _cha;
    protected int _luck;
    protected int _mag;

    //calculation
    public float MaxHealth => _baseHealth + (_vit * 5);
    public int Level => (int)(_exp / 1000);
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "Steven" : value;
    }

    public Jobless()
    {
        _name = "";
        _baseHealth = 100.0f;
        _exp = 0.0f;

        _str = 0;
        _dex = 0;
        _vit = 0;
        _cha = 0;
        _luck = 0;
        _mag = 0;
    }

    public Jobless(string name = "Max", float baseHealth = 500, float exp = 100
        , int str = 8, int dex = 8, int vit = 8, int cha = 8, int luck = 8, int mag = 8)
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

    public string GetProperties()
    {
        var properties =
            $"{nameof(_name)}:{_name}, {nameof(_baseHealth)}:{_baseHealth}, {nameof(_exp)}:{_exp}, {nameof(_str)}:{_str}, {nameof(_dex)}:{_dex}, {nameof(_vit)}:{_vit}, {nameof(_cha)}:{_cha}, {nameof(_luck)}:{_luck}, {nameof(_mag)}:{_mag}";

        return properties;
    }
}
