import { Vue } from 'vue-class-component';
import axios from 'axios';

export default class Dashboard extends Vue {
    message = 'Loading...';
    status = '';

    mounted() {
        axios('jobs')
            .then(data => {
                this.message = data.data; 
                this.status = 'Success';
            })
            .catch(() => {
                this.status = 'Error';
            });
    }
}
