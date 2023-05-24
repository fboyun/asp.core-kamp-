using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newletterDal;

        public NewsLetterManager(INewsLetterDal newletterDal)
        {
            _newletterDal = newletterDal;
        }

        public void AddNewsLetter(NewsLetter newsletter)
        {
            _newletterDal.Insert(newsletter);
        }
    }
}
