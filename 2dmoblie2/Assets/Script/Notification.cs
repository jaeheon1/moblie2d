using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleAndroidNotifications;
using System;
using System.Text;

public class Notification : MonoBehaviour
{
    //�˸� ���� 

    private string title = "�˸�";

    //�˸� ���� 
     
    private string content="�ۿ� �����ؼ� ������ ������ �ּ���";


    void Start()
    {
        OnApplicationPause(true);
    }

    private void OnApplicationPause(bool pause)
    {
        //�ȵ���̵� �϶� ����Ǵ� �ڵ�
#if UNITY_ANDROID
        //��ϵ� �˸� ��� ����
        NotificationManager.CancelAll(); 

        if(pause)
        {
            //���� ��� �� �� ���� �ð� �Ŀ� �˸��ϴ� ���
            //AddMinutes: ��� �Ŀ� �˸��� ���� �� �ֵ��� �����մϴ�.
            DateTime timeNotify = DateTime.Now.AddMinutes(1);

            TimeSpan time = timeNotify - DateTime.Now;

            NotificationManager.SendWithAppIcon(time, title, content, Color.white, NotificationIcon.Bell);

            // ������ �ð��� �˸��ϴ� ��� 
            DateTime specifiedTime = Convert.ToDateTime("19:30:00 PM");

            TimeSpan tempTime = specifiedTime - DateTime.Now;

            if (tempTime.Ticks > 0)
            {
                NotificationManager.SendWithAppIcon(time, title, content, Color.gray, NotificationIcon.Star);

            }
        }
#endif
    }

}
