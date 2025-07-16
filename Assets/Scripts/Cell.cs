using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] private Image buttonBackgroundImage;
    [SerializeField] private TMP_Text buttonText;
    
    private bool _isRevealed;
    private Color _revealedCellColor = new (0f, .138f, .267f, 1f);
    
    private void AnimateCell()
    {
        // TODO: replace code below with animation
        buttonBackgroundImage.color = _revealedCellColor;
        buttonText.gameObject.SetActive(true);
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
