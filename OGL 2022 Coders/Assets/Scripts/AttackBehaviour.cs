using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour
{
   
    public AudioClip audioClip;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("start attack state");
        AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("end attack state");
        //joystick.enabled = true;
    }


}
