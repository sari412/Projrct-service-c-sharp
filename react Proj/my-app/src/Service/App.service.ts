import axios from 'axios'
export default new class ApiService {
    
    BASE_URL="http://localhost:7152/";
   
    getListApi(){
        return axios.get(`${this.BASE_URL}/Client/GetClients`);
    }

    createNewUser(){
        return axios.post(`${this.BASE_URL}/Client/CreateClient`);
    }
}