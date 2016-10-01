﻿using System.Net;
using System.Web.Http;
using QoalaWS.DAO;
using QoalaWS.Filters;

namespace QoalaWS.Controllers
{
    public class DevicesController : ApiController
    {
        private QoalaEntities db = new QoalaEntities();

        [HttpGet]
        [BasicAuthorization(Permission = Permission.Admin)]
        [Route("devices/")]
        public IHttpActionResult GetDevices(int page = 1)
        {
            var totalNumberPage = Device.totalNumberPage(db);
            var data = new
            {
                users = Device.All(db, page),
                pagination = new
                {
                    total_number_pages = totalNumberPage,
                    next_page = totalNumberPage > page,
                    current_page = page,
                    previous_page = page > 1 && page <= totalNumberPage
                }
            };
            return Ok(data);
        }

        [HttpGet]
        [BasicAuthorization]
        [Route("users/{id_user}/devices/{id_device}")]
        public IHttpActionResult Get(decimal id_user, decimal id_device)
        {
            if (!Device.belongsToUser(db, id_device, id_user))
                return NotFound();

            Device device = Device.findById(db, id_device);

            return Ok(device.Serializer());
        }

        [HttpPost]
        [BasicAuthorization]
        [Route("users/{id_user}/devices")]
        public IHttpActionResult Create(decimal id_user, Device device)
        {
            if (DAO.User.findById(db, id_user) == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            device.ID_USER = id_user;

            device.Add(db);

            return Created(
                "",
                device.Serializer()
            );
        }

        [HttpPut]
        [BasicAuthorization]
        [ValidateModel]
        [Route("users/{id_user}/devices/{id_device}")]
        public IHttpActionResult Update(decimal id_user, decimal id_device, Device device)
        {
            if (!Device.belongsToUser(db, id_device, id_user))
                return NotFound();

            Device d = Device.findById(db, id_device);

            if (d == null)
                return NotFound();

            device.ID_DEVICE = id_device;

            if (device.ALIAS == null)
                device.ALIAS = d.ALIAS;
            if (device.COLOR == null)
                device.COLOR = d.COLOR;
            if (device.FREQUENCY_UPDATE == 0)
                device.FREQUENCY_UPDATE = d.FREQUENCY_UPDATE;
            if (device.ID_USER == 0)
                device.ID_USER = d.ID_USER;
            
            device.Update(db);
            return StatusCode(HttpStatusCode.NoContent);
        }
        
        [HttpDelete]
        [BasicAuthorization]
        [Route("users/{id_user}/devices/{id_device}")]
        public IHttpActionResult Delete(decimal id_user, decimal id_device)
        {
            if (!DAO.Device.belongsToUser(db, id_device, id_user))
                return NotFound();

            Device device = DAO.Device.findById(db, id_device);
            if (device == null)
                return NotFound();

            device.Delete(db);
            return StatusCode(HttpStatusCode.NoContent);
        }


        [HttpPut]
        [BasicAuthorization]
        [ValidateModel]
        [Route("users/{id_user}/devices/{id_device}/turn_alarm")]
        public IHttpActionResult TurnAlarm(decimal id_user, decimal id_device, Device device)
        {
            if (!Device.belongsToUser(db, id_device, id_user))
                return NotFound();

            Device d = Device.findById(db, id_device);

            if (d == null)
                return NotFound();

            device.ID_DEVICE = id_device;

            if (device.ALARM == null)
                device.ALARM = d.ALARM;

            device.TurnAlarm(db);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}