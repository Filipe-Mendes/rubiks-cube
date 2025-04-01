using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] public CUSTOM_COLOR[] colors = new CUSTOM_COLOR[6];

    private static readonly Dictionary<CUSTOM_COLOR, Color> colorMap = new Dictionary<CUSTOM_COLOR, Color>
    {
        { CUSTOM_COLOR.RED, Color.red },
        { CUSTOM_COLOR.YELLOW, Color.yellow },
        { CUSTOM_COLOR.GREEN, Color.green },
        { CUSTOM_COLOR.BLUE, Color.blue },
        { CUSTOM_COLOR.WHITE, Color.white },
        { CUSTOM_COLOR.BLACK, Color.black }
    };

    void Start()
    {

    }



}

