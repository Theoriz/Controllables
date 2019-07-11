using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedTextureControllable : Controllable
{
    [OSCProperty] public bool SpoutOutput;

    [Header("Output settings")]
    [Tooltip("in pixels")]
    [OSCProperty] public int outputWidth;
    [Tooltip("in pixels")]
    [OSCProperty] public int outputHeight;

    public override void OnScriptValueChanged(string name)
    {
        base.OnScriptValueChanged(name);
        SpoutOutput = (TargetScript as SharedTexture).enabled;
    }

    public override void OnUiValueChanged(string name)
    {
        base.OnUiValueChanged(name);
        (TargetScript as SharedTexture).enabled = SpoutOutput;
    }
}

