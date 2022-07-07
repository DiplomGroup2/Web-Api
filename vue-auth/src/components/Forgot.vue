<template> 
     <form @submit.prevent="handleSubmit">
     <div  v-if="message" class="alert alert-success" role="alert">
          {{message}}
    </div>
    <error v-if="error" :error="error" />
     <h3>Forgot Password</h3>
     <div class="form-group">
        <label>Email</label>
        <input type="email" class="form-control"  v-model="login" placeholder="Email"/>
     </div>
     <button class="btn btn-primary btn-block">Submit</button>
     </form>
</template>

<script>
import axios from 'axios'
import Error from './Error.vue'

      export default 
{
             name:'FORGOT',
             components:{
        Error
     },
             data(){
                return{
                    login:'',
                    message:'',
                    return:''
                }
             },
             methods:{
               async  handleSubmit()
                {
                    try{
               await axios.post('forgot',{
                login:this.login
                });

                this.message = 'The mail was sent!';  
                this.error='';

                }      catch(e)   {
                    this.error='Error occured!';
                    this.message ='';

                }    
            }
         }
}

</script>