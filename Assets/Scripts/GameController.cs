using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    [SerializeField] private Cell[] cells;
    [SerializeField] private BackgroundAnimator backgroundAnimator;
    [SerializeField] private Button button;
    [SerializeField] private GameObject orb;
    [SerializeField] private Transform holder;
    [SerializeField] private AnimationDataSO animationData;

    private void Commence()
    {
        Cell cell = GetRandomCell();
        if (cell != null)
        {
            cell.SetRevealed();
            
            GameObject newOrb = Instantiate(orb, holder);
            Vector3 start = newOrb.transform.position;
            Vector3 end = cell.transform.position;

            // Create an elevated midpoint for the curve
            Vector3 mid = (start + end) / 2 + Vector3.left * 1f;

            // Define a 3-point path: start → mid → end
            Vector3[] path = new Vector3[] { start, mid, end };

            newOrb.transform.localScale = Vector3.zero;
            newOrb.transform.gameObject.SetActive(true);
            
            Sequence sequence = DOTween.Sequence(); 
            
            sequence.Append(newOrb.transform.DOScale(Vector3.one, animationData.scaleDuration).SetEase(Ease.OutBack));
            sequence.Append(newOrb.transform.DOPath(path, animationData.moveDuration, PathType.CatmullRom).SetEase(Ease.InOutSine));
            sequence.AppendInterval(animationData.moveCompleteDelay).OnComplete(() =>
            {
                Destroy(newOrb);
                cell.RevealCell();
                CheckLastCell();
            });
        }
        else
        {
            DisableButtonAndStartBackgroundAnimation();
        }
    }

    private void CheckLastCell()
    {
        Cell isNextCellExists = GetRandomCell();
        if (isNextCellExists == null)
        {
            DisableButtonAndStartBackgroundAnimation();
        }
    }
    
    private void DisableButtonAndStartBackgroundAnimation()
    {
        backgroundAnimator.AnimateBackground();
        DisableButton();
    }

    public void OnButtonClick()
    {
        //******
        //DO NOT edit this method
        //******
        Commence();
    }
    
    private Cell GetRandomCell()
    {
        //******
        //DO NOT edit this method
        //******
        int startX = Random.Range(0, cells.GetLength(0));

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            int indexX = (startX + i) % cells.GetLength(0);
            Cell temp = cells[indexX];

            if (temp == null) continue;
            if (!temp.IsRevealed()) return temp;
        }

        return null;
    }
    
    private void DisableButton()
    {
        //******
        //DO NOT edit this method
        //******
        button.interactable = false;
    }
}