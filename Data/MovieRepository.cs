﻿using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
    }
}
