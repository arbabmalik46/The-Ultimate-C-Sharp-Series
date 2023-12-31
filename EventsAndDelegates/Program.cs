using System;
using System.Collections;
using System.Collections.Generic;

namespace EventsAndDelegates
{
    class Program
	{
		static void Main(string[] args)
		{
			Video video = new Video() { Title = "Video 1"};
			VideoEncoder encoder = new VideoEncoder(); //publisher
			MailService mailService = new MailService(); //subscriber
			MessageService messageService = new MessageService(); //subscriber
			encoder.VideoEncoded += mailService.OnVideoEncoded;
			encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.Encode(video);
        }
	}
}