﻿using System;
using System.Collections.Generic;
using System.Text;
using J6.Cms.Domain.Interface.Site.Link;

namespace J6.Cms.DataTransfer
{
    public struct SiteLinkDto
    {
        public int Pid
        {
            get;
            set;
        }

        public SiteLinkType Type
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public string Uri
        {
            get;
            set;
        }

        public string ImgUrl
        {
            get;
            set;
        }

        public string Target
        {
            get;
            set;
        }

        public int SortNumber
        {
            get;
            set;
        }

        public bool Visible
        {
            get;
            set;
        }

        public string Bind
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public static SiteLinkDto ConvertFrom(ISiteLink link)
        {
            return new SiteLinkDto
            {
                Bind = link.Bind,
                Id = link.Id,
                ImgUrl = link.ImgUrl,
                SortNumber = link.SortNumber,
                Pid = link.Pid,
                Target = link.Target,
                Text = link.Text,
                Type = link.Type,
                Uri = link.Uri,
                Visible = link.Visible
            };
        }
    }
}