using Dating.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize); 

            /*
             Ex: count = 13 members
             page size = 5 members per page
             13/5 = 2.6
             Math.Ceiling = = 3 pages
             */

            this.AddRange(items);
        }

        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source,
            int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            /*
             Ex: requesting 2nd page = page number = 2
             page size = 5 
                Skip((2-1)*5) = Skip the first 5 members
                take(5) = take next 5 members
             use ToListAsync to execute that request
             */
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
