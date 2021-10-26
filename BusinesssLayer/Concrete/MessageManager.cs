using BusinesssLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _ımessageDal;

        public MessageManager(IMessageDal ımessageDal)
        {
            _ımessageDal = ımessageDal;
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _ımessageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
