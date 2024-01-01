using System;
using System.Collections;
using System.Collections.Generic;

namespace EventsAndDelegates
{
    class Program
	{
		static void Main(string[] args)
		{
            #region Event Handling With Custom Delegate
            //Video video = new Video() { Title = "Inception"};
            //VideoEncoder encoder = new VideoEncoder(); //publisher
            //MailService mailService = new MailService(); //subscriber
            //MessageService messageService = new MessageService(); //subscriber
            //encoder.VideoEncoded += mailService.OnVideoEncoded;
            //encoder.VideoEncoded += messageService.OnVideoEncoded;
            //         encoder.Encode(video);
            #endregion

            #region Event Handling With Builtin Delegate
            Audio audio = new Audio() { Title = "Milli Naghma", Singer = "Atif Aslam", Album = "2024" };
            AudioEncoder encoder = new AudioEncoder();
            NotificationService notificationService = new NotificationService();
            CustomNotification customNotification = new CustomNotification();
            encoder.AudioEncoderInitialized += notificationService.OnAudioEncoderInitialized;
            encoder.AudioEncoderInitialized += customNotification.OnAudioEncoderInitialized;
            encoder.Encode(audio);
            #endregion


        }
	}
}