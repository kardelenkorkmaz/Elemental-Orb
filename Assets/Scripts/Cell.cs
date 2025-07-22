using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] private Image buttonBackgroundImage;
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private Animation animation;
    
    private bool _isRevealed;
    private Color _revealedCellColor = new (0f, .138f, .267f, 1f);

    private void Start()
    {
        animation = GetComponent<Animation>();
    }

    private void AnimateCell()
    {
        animation.Play();
    }
    
    public bool IsRevealed()
    {
        //******
        //DO NOT edit this method
        //******
        return _isRevealed;
    }
    
    public void SetRevealed()
    {
        //******
        //DO NOT edit this method
        //******
        _isRevealed = true;
    }

    public void RevealCell()
    {
        //******
        //DO NOT edit this method
        //******
        AnimateCell();
    }
}
