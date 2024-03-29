﻿using PlakDukkani.Model.Entities;

namespace PlakDukkani.BLL.Abstract
{
    public interface IGenreBLL : IBaseBLL<Genre>
    {
        int GetGenreID(string genreName);
    }
}
