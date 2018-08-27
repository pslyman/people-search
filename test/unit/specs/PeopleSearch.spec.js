import Vue from 'vue'
import PeopleSearch from '@/components/PeopleSearch'
import axios from 'axios'

describe('PeopleSearch.vue', () => {
  it('should render correct header', () => {
    const Constructor = Vue.extend(PeopleSearch)
    const vm = new Constructor().$mount()
    expect(vm.$el.querySelector('h1').textContent)
      .to.equal('People Search')
  })

  /* Ideally I would mock the return data with Moxios, or Sinon, instead of actually getting an API response. On my todo list */
  it('API call returns data', () => {
    let tempPeople = []
    const getPeople = async function () {
      axios.get(`http://localhost:8081/api/people`)
        .then(response => {
          tempPeople = response.data
        })
        .catch(e => {
          this.errors.push(e)
        })
    }
    getPeople()
    expect(tempPeople).to.not.equal([])
  })
})
