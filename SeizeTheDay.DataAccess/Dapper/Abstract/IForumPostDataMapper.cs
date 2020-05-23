﻿using SeizeTheDay.Core.DataAccess.Abstract;
using System.Collections.Generic;
using Xgteamc1XgTeamModel;

namespace SeizeTheDay.DataAccess.Dapper.Abstract
{
    public interface IForumPostDataMapper : IDataMapper<ForumPost>
    {
        IEnumerable<ForumPost> GetForumPosts();
    }
}