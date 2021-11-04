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


        public object GetListBox()
        {
            throw new NotImplementedException();
        }

        public Message GetByID(int id)
        {
            return _ımessageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _ımessageDal.List(x => x.ReceiverMail == "samedsargın@gmail.com");
        }


        public List<Message> GetListSendbox()
        {
            return _ımessageDal.List(x => x.SenderMail == "samedsargın@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _ımessageDal.Insert(message);
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
