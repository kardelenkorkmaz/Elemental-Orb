using UnityEngine;

[CreateAssetMenu(fileName = "AnimationDataSO", menuName = "Variables/AnimationDataSO")]
public class AnimationDataSO : ScriptableObject
{
    public float scaleDuration;
    public float moveDuration;
    public float moveCompleteDelay;
    public float hitScaleAmount;
    public float hitScaleDuration;
}
