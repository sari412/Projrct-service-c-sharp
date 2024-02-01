import React, { FC, useState } from 'react';
import './ApiRequest.scss';
import { useEffect } from 'react';
import AppService from '../../Service/App.service';
interface ApiRequestProps { }

const ApiRequest: FC<ApiRequestProps> = () => {
  const [listApiUsers, setListApiUsers] = useState<any[]>([]);

  useEffect(() => {
    loudUsers();
  }, [])

  const loudUsers = () => {
    AppService.getListApi().then((res) => {
      setListApiUsers(res.data);
    })
  }

  return <div className="Api-Request">
    <h2>hello</h2>
    <ul>{listApiUsers.map((user) => {
      return <li>{user}</li>
    })}
    </ul>
  </div>
};

export default ApiRequest;
