﻿using System;
using System.Collections;

namespace logic
{
	public class gateproxy
	{
		public gateproxy(juggle.Ichannel ch)
		{
			_caller = new caller.logic_call_gate(ch);
		}

		public void reg_logic()
        {
            log.log.trace(new System.Diagnostics.StackFrame(true), service.timerservice.Tick, "begin connect gate server");

			_caller.reg_logic(logic.uuid);
		}

        public void connect_sucess(string client_uuid)
        {
            _caller.connect_sucess(client_uuid);
        }

        public void ack_client_get_logic(String uuid, String result)
		{
			_caller.ack_client_get_logic(uuid, result);
		}

        public void disconnect_client(String uuid)
        {
            _caller.disconnect_client(uuid);
        }

		public void forward_logic_call_client(String uuid, String module, String func, ArrayList argv)
		{
			_caller.forward_logic_call_client(uuid, module, func, argv);
		}

		public void forward_logic_call_group_client(ArrayList uuids, String module, String func, ArrayList argv)
		{
			_caller.forward_logic_call_group_client(uuids, module, func, argv);
		}

		public void forward_logic_call_global_client(String module, String func, ArrayList argv)
		{
			_caller.forward_logic_call_global_client(module, func, argv);
		}

		private caller.logic_call_gate _caller;
	}
}

