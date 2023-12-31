﻿using Data_Transfer_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class VideoDataAccess:PostDataContext
    {
        public int AddVideoDataAccess(Video model)
        {
            Video addVideos=dbcontext.Videos.Add(model);
            dbcontext.SaveChanges();

            if(addVideos.VideoID!=0)
            {
                return addVideos.VideoID;
            }
            else
            {
                return addVideos.VideoID;
            }
        }

        public void DeleteVideoDataAccess(int iD)
        {
            Video video=dbcontext.Videos.FirstOrDefault(x => x.VideoID == iD);
            video.isDeleted = true;
            video.DeletedDate = DateTime.Now;
            video.LastUpdateDate = DateTime.Now;
            video.LastUpdateUserID = UserStatic.UserId;
            dbcontext.SaveChanges();
        }

        public int UpdateVideoDataAccess(VideoDataTransfer video)
        {
            Video videoData=dbcontext.Videos.Where(x=>x.VideoID==video.VideoID).FirstOrDefault();
            if(videoData!=null&&videoData.VideoID!=0)
            {
                videoData.Title=video.Title;
                videoData.OriginalVideoPath=video.OriginalVideoPath;
                videoData.LastUpdateDate=DateTime.Now;
                videoData.LastUpdateUserID=UserStatic.UserId;
                videoData.VideoPath=video.VideoPath;
                dbcontext.SaveChanges();
                return videoData.VideoID;
            }
            else
            {
                return videoData.VideoID;
            }
        }

        public List<Video> VideoListDataAccess()
        {
            List<Video> videoList = new List<Video>();
            videoList=dbcontext.Videos.Where(x=>x.isDeleted==false).OrderByDescending(x=>x.AddDate).ToList();
            if(videoList.Count>0 )
            {
                return videoList;
            }
            return videoList;
        }
    }
}
