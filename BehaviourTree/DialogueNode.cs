using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNode : CompositeNode
{
    [TextArea()]
    public string Text;
    [Space()]
    public DI_Dialogue.Character Character;
    public float duration;
    public string Sequence;

    float startTime;
    protected override void OnStart()
    {
        startTime = Time.time;
    }

    protected override void OnStop()
    {
    }

    protected override State OnUpdate()
    {
        if ((Time.time - startTime) > duration)
        {
            return State.Success;
        }

        return State.Running;
    }
}
