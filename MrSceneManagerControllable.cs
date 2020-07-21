using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrSceneManagerControllable : Controllable {

    public List<string> scenesName;
    [OSCProperty(TargetList = "scenesName", IncludeInPresets = false)] public string activeScene;

    [OSCProperty]
    public bool AutoSwitchScene;
    [OSCProperty]
    public bool Loop;
    [OSCProperty]
    public float AutoSwitchTimer;

    private MrSceneManager manager;

	public override void Awake() {
		base.Awake();

        manager = TargetScript as MrSceneManager;
	}

	public override void OnScriptValueChanged(string name)
    {
        base.OnScriptValueChanged(name);
        scenesName = manager.scenesName;
        activeScene = manager.activeScene;
    }

    public override void OnUiValueChanged(string name)
    {
        base.OnUiValueChanged(name);
        manager.activeScene = activeScene;
        manager.scenesName = scenesName;
    }

    [OSCMethod]
    public void Next()
    {
        manager.Next();
    }

    [OSCMethod]
    public void Previous()
    {
        manager.Previous();
    }

    [OSCMethod]
    public void Reload()
    {
        manager.Reload();
    }

    [OSCMethod]
    public void LoadSceneWithName(string name)
    {
        manager.LoadSceneWithName(name);
    }
}
