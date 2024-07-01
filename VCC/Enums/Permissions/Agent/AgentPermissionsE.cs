using System;
namespace VCC.Models.Entities.Permissions.Agent
{
    public enum AgentPermissionsE
    {
        // ------------CALL------------
        // Dialup rules
        CAN_MAKE_CALL,
        CAN_TRANSFER_CALL,
        CAN_CREATE_CONFERENCE,
        CAN_RECEIVE_TRANSFER,
        //After Call Recevied actions
        CAN_CREATE_CALLBACK,
        CAN_RECORD_CALL,
        CAN_MAKE_TEST_CALL,
        CAN_WRAPUP_CALL,
        CAN_HOLD_CALL,
        CAN_PARK_CALL,
        // Call View Releated Stuff 
        CAN_VIEW_MISSED_CALL,

    }
}

