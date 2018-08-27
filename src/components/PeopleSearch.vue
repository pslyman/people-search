<template>

<div class="container-fluid">
    <div class="header">
      <h1>{{ msg }}</h1>
    </div>
    <div class="row">
      <div class="col-md-12">
        <b-button-group>
        <b-form-input v-model="searchDelay" type="text" placeholder="Search by name"></b-form-input>
        <b-button @click="delaySearch">Search</b-button> <!-- Button isn't required, but I did it to help with simulating a slow search. Alternatively I could use Debounce. -->
        </b-button-group>

        <table class="table table-striped table-bordered table-sm">

            <thead>
              <tr>
                <th>Name</th> <!-- Could add @click="sort(Name)" to add sorting functionality later on -->
                <th>Age</th>
                <th>Eye Color</th>
                <th>Address</th>
                <th>Fact</th>
                <th>Avatar</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="people in filteredPeople" v-bind:key="people.name">
                <td>{{people.name}}</td>
                <td>{{people.age}}</td>
                <td>{{people.eyecolor}}</td>
                <td>{{people.address}}</td>
                <td>{{people.fact}}</td>
                <td><img class='images' :src='people.image' alt="image placeholder"></td>
              </tr>
            </tbody>
          </table>
          <clip-loader v-if="loader"></clip-loader>
        <p>
      <!-- Pagination and Sorting would be next on the list if it was required. Ideally the API would handle it. -->
      <!--<button @click="prevPage">Previous</button>
          <button @click="nextPage">Next</button> -->
        </p>

      </div>
    </div>
</div>

</template>

<script>
import ClipLoader from 'vue-spinner/src/PulseLoader.vue'
import axios from 'axios'

export default {
  name: 'PeopleSearch',
  data () {
    return {
      msg: 'People Search',
      search: '',
      searchDelay: '',
      people: [],
      loader: true
    }
  },

  components: {
    ClipLoader
  },

  mounted () {
    this.getPeople()
  },

  methods: {

    async getPeople () {
      axios.get(`http://localhost:8081/api/people`)
        .then(response => {
          this.people = response.data
        })
        .catch(e => {
          this.errors.push(e)
        })
      this.loader = false
    },

    /* Here's a simulated delay for you */
    delaySearch () {
      this.loader = true
      this.search = '---'
      setTimeout(() => { this.search = this.searchDelay; this.loader = false }, 750)
    }
  },

  computed: {
    filteredPeople () {
      return this.people.filter((person) => {
        return person.name.toLowerCase().includes(this.search.toLowerCase())
      })
    }
  }
}

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
img {
  width: 50px;
  border-radius: 50%;
}
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
